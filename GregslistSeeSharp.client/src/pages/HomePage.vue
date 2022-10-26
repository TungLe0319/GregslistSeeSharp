<template>
<div>

</div>
</template>

<script>
import { onMounted } from "vue";
import { carsService } from "../services/CarsService.js";
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

  onMounted(()=>{
    getCars()
  })
        return {};
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
