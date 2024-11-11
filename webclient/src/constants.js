const BACK_URL = "http://localhost:5198/api/";

export const getStoragesURL = (query) =>
  BACK_URL + "storages" + `?text=${query}`;
