import { AppState } from "../AppState.js"
import { Job } from "../models/Job.js"
import { api } from "./AxiosService.js"


class JobsService{
async getJobs(){
  const res = await api.get('/api/jobs')
  AppState.jobs = res.data.map(j=> new Job(j))
}

async addJob(editable){
const res = await api.post('/api/jobs')
// let job = new Job(res.data)
//AppState.jobs = [...AppState.jobs, job]
}
}

export const jobsService = new JobsService()