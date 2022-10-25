<template>
  <div class="jobs container">
    <div class="row justify-content-center">

      <jobCard  v-for="j in  jobs" :key="j.id" :job="j" />

    </div>


  </div>
</template>

<script>
import { computed } from "@vue/reactivity"
import { AppState } from "../AppState.js"
import { jobsService } from "../services/JobsService.js"


  
export default {

  
   setup(){
    async function getJobs(){
  try {
      await jobsService.getJobs()
    } catch (error) {
      console.error('[]',error)
      Pop.error(error)
    }
}
getJobs()
      return{
        jobs:computed(() => AppState.jobs)
      }
    }


}
</script>




<style scoped lang="scss">
  ::-webkit-scrollbar{
    display: none;
  }
.scrollme{
  max-height: 100vh;
  overflow: auto;
}
</style>

