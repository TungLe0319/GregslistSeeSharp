<template>
  <div class="houses container">
  <div class="row justify-content-center scrollme"  >

<houseCard v-for="h in houses" :key="h.id" :house="h" />
  </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity"
import { AppState } from "../AppState.js"
import { housesService } from "../services/HomesService.js"

export default {
  

   setup(){
    async function getHouses(){
  try {
      await housesService.getHouses()
    } catch (error) {
      console.error('[]',error)
      Pop.error(error)
    }
    
    
}
getHouses()
      return{
        houses:computed(() => AppState.houses),
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

