import { AppState } from "../AppState.js"
import { Home } from "../models/Home.js";
import { api } from "./AxiosService.js"

class HomesService {
  async getHomes() {
    const res = await api.get('/api/homes');

    console.log(res.data);
    AppState.homes = res.data.map((h) => new Home(h));
  }

  async addHome(editable) {
    const res = await api.post('/api/homes');
    // let job = new Job(res.data)
    //AppState.jobs = [...AppState.jobs, job]
  }
}

export const homesService = new HomesService()