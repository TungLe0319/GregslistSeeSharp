<template>
<div>
  <div class="col-md-6">
    
  </div>
<CarCard :car="c"  v-for="c in cars"/>
</div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted } from "vue";
import { AppState } from "../AppState.js";

import { carsService } from "../services/CarsService.js";
import { homesService } from "../services/HomesService.js";
import Pop from "../utils/Pop.js";



export default {

    setup() {

  async function getCars(){
    try {
        await carsService.getCars()
      } catch (error) {
        Pop.error(error,'[]')
      }
  }

  async function getHomes(){
    try {
       await homesService.getHomes()
      } catch (error) {
       Pop.error(error)
      }
  }

  onMounted(()=>{
    getCars()
    getHomes()
  })
        return {
cars: computed(() => AppState.cars),

        };
    },
    components: { }
}
</script>

<style scoped lang="scss">
.home {
  display: grid;
  height: 80vh;
  place-content: center;
  text-align: center;
  user-select: none;

  .home-card {
    width: 50vw;

    >img {
      height: 200px;
      max-width: 200px;
      width: 100%;
      object-fit: contain;
      object-position: center;
    }
  }
}
</style>
