<template>
  <div class="card elevation-3 mx-4 my-2" style="width: 18rem">
    <div class="d-flex justify-content-center">
      <img
        :src="car?.imgUrl"
        alt=""
        class="img-fluid rounded mt-2 elevation-4 forcedimg"
      />
    </div>
    <div class="card-body">
      <!-- <div>
        <img :src="seller.picture" :alt="seller?.name" :title="seller?.name" height="40" class="rounded-circle">
        <i class="mdi mdi-minus-box fs-1" ></i>
      </div> -->
      <div class="d-flex justify-content-between">
        <h6>make: {{ car.make }}</h6>
        <h6>model: {{ car.model }}</h6>
      </div>
    </div>
  </div>
</template>

<script>
import { onMounted } from 'vue';
import { Car } from '../models/Car.js';
import { SellerProfile } from '../models/SellerProfile.js';
import Pop from '../utils/Pop.js';

export default {
  props: {
    car: { type: Car, required: true },
    // seller: { type: SellerProfile, required: true },
  },

  setup(props) {
    onMounted(() => {});

    return {
      async deleteClassified() {
        try {
          const yes = await Pop.confirm('You sure?');
        } catch (error) {
          console.error('[]', error);
          Pop.error(error);
        }
      },
    };
  },
};
</script>

<style lang="scss" scoped>
.forcedimg {
  height: 200px;
  width: 260px;
  object-fit: cover;
}
</style>
