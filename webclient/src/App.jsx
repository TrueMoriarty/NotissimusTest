import { TextField, Autocomplete } from "@mui/material";
import { getAsync } from "./axios";
import { getStoragesURL } from "./constants";
import parse from "autosuggest-highlight/parse";
import match from "autosuggest-highlight/match";
import { useState } from "react";

function App() {
  const [options, setOptions] = useState([]);
  const [inputValue, setInputValue] = useState("");

  const handleSearch = async (query) => {
    if (!query) return;
    const { isOk, data } = await getAsync(getStoragesURL(query));

    if (isOk) setOptions(data);
  };

  return (
    <Autocomplete
      sx={{ width: 300 }}
      options={options}
      getOptionLabel={(option) => option.text}
      renderInput={(params) => (
        <TextField {...params} label="Highlights" margin="normal" />
      )}
      onInputChange={(event, newInputValue) => {
        handleSearch(newInputValue);
        setInputValue(newInputValue);
      }}
      renderOption={(props, option, { inputValue }) => {
        const { key, ...optionProps } = props;
        const matches = match(option.text, inputValue, { insideWords: true });
        const parts = parse(option.text, matches);

        return (
          <li key={key} {...optionProps}>
            <div>
              {parts.map((part, index) => (
                <span
                  key={index}
                  style={{
                    fontWeight: part.highlight ? 700 : 400,
                  }}
                >
                  {part.text}
                </span>
              ))}
            </div>
          </li>
        );
      }}
    />
  );
}

const top100Films = [
  { text: "The Shawshank Redemption", year: 1994 },
  { text: "The Godfather", year: 1972 },
  { text: "The Godfather: Part II", year: 1974 },
  { text: "The Dark Knight", year: 2008 },
  { text: "12 Angry Men", year: 1957 },
];

export default App;
