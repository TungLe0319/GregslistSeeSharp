import { AppState } from "../AppState.js"
import { Classified } from "../models/Classified.js"
import { api } from "./AxiosService.js"

class ClassifiedsService{


  async getClassifieds(){
    const res = await api.get('api/classifieds')
    AppState.classifieds = res.data.map(c=> new Classified(c))
    console.log(AppState.classifieds);
  }

  async deleteClassified(id){
const res = await api.delete(`api/classifieds/${id}`)
AppState.classifieds = AppState.classifieds.filter(c => c.id != id)

  }
}
export const classifiedService = new ClassifiedsService()