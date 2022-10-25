<template>
  <div class="offcanvas-form">



<div class="offcanvas offcanvas-start bg-dark test rounded-end rounded-bottom" tabindex="-1" id="formOffCanvas" aria-labelledby="formOffCanvasLabel">
  
  <div class="offcanvas-body mt-3">
    <!-- NOTE Car-Form Here -->
    <div class="car-form text-dark">
     <form onsubmit="handleSubmit()">

  <div class="form-floating mb-3">
    <input type="text" class="form-control" name="make" required minlength="3" maxlength="20" v-model="editable.make" >
    <label for="make">Make</label>
  </div>

  <div class="form-floating mb-3">
    <input type="text" class="form-control" name="model" required v-model="editable.model" >
    <label for="model">Model</label>
  </div>

  <div class="form-floating mb-3">
    <input type="number" class="form-control" name="year" required min="1886" max="9999" v-model="editable.year">
    <label for="year">Year</label>
  </div>

  <div class="form-floating mb-3">
    <input type="number" class="form-control" name="price" required min="0" v-model="editable.price">
    <label for="price">Price</label>
  </div>

  <div class="form-floating mb-3">
    <input type="url" class="form-control" name="imgUrl" 
    v-model="editable.imgUrl" >
    <label for="imgUrl">Image Url <i>(We are too lazy for uploads)</i></label>
  </div>

  <div class="form-floating">
    <textarea class="form-control"  name="description" v-model="editable.description"></textarea>
    <label for="description">Description</label>
  </div>

  <div class="d-flex my-4 gap-5 align-items-center">
    <button class="btn btn-light" type="reset">Cancel</button>
    <button class="btn btn-light" type="submit">
  Submit </button>
  </div>


</form>
    </div>
    <!-- ! Car-Form -->
    <!-- NOTE House-Form -->
    <div class="house-form text-dark" v-if="placeholder==true">
      <form onsubmit="app.housesController.handleSubmit()">
       
      <div class="form-floating mb-3">
        <input type="number" class="form-control" name="bedrooms" required minlength="3" value="${editable.bedrooms}">
        <label for="bedrooms">Bedrooms</label>
      </div>
     
      <div class="form-floating mb-3">
        <input type="number" class="form-control" name="bathrooms" value="${editable.bathrooms}">
        <label for="bathrooms">Bathrooms</label>
      </div>
     
      <div class="form-floating mb-3">
        <input type="number" class="form-control" name="levels" required min="1" value="${editable.levels}">
        <label for="levels">Levels</label>
      </div>
     
      <div class="form-floating mb-3">
        <input type="url" class="form-control" name="imgUrl" value="${editable.imgUrl}" >
        <label for="imgUrl">Picture!</label>
      </div>
     
      <div class="form-floating mb-3">
        <input type="number" class="form-control" name="year" required  max="9999" value="${editable.year}">
        <label for="year">Year</label>
      </div>
     
     <div class="form-floating mb-3">
        <input type="number" class="form-control" name="price" required min="0" value="${editable.price}">
        <label for="price">Price</label>
      </div>
     
      <div class="form-floating">
        <textarea class="form-control" placeholder="Describe your Listing" name="description">${editable.description}</textarea>
        <label for="description">Description</label>
      </div>
     
      <div class="d-flex my-4 gap-5 align-items-center">
         <button class="btn" type="reset">Cancel</button>
         <button class="btn btn-primary" type="submit">${
           editable.id ? 'Save Changes' : 'Create'
         } </button>
      </div>
     
     
     </form>

    </div>

    <!-- ! House-Form -->
    <!-- NOTE Job-Form -->

    <div class="job-form text-dark" v-if="placeholder==true">
       <form onsubmit="app.jobsController.handleSubmit()">

 

  <div class="form-floating mb-3">
    <input type="text" class="form-control" name="company" required value="${
      editable.company
    }">
    <label for="company">Company</label>
  </div>

  <div class="form-floating mb-3">
    <input type="text" class="form-control" name="jobTitle" required value="${
      editable.jobTitle
    }">
    <label for="jobtitle">Job title</label>
  </div>

  <div class="form-floating mb-3">
    <input type="number" class="form-control" name="hours" required value="${
      editable.hours
    }">
    <label for="hours">Hours</label>
  </div>

  <div class="form-floating mb-3">
    <input type="number" class="form-control" name="rate" required  value="${
      editable.rate
    }">
    <label for="rate">Rate</label>
  </div>

 

  <div class="form-floating">
    <textarea class="form-control" placeholder="Describe your Listing" name="description">${
      editable.description
    }</textarea>
    <label for="description">Description</label>
  </div>

  <div class="d-flex my-4 gap-5 align-items-center">
     <button class="btn" type="reset">Cancel</button>
    <button class="btn btn-primary" type="submit">${
      editable.id ? 'Save Changes' : 'Create'
    } </button>
  </div>


</form>
    </div>
    <!-- ! Job-Form -->
  </div>
</div>

  </div>
</template>


<script>
import { ref } from "vue";

export default {
  setup(){
    const editable =ref({})
    return {
      editable,
placeholder:false
    }
  }
}
</script>


<style lang="scss" scoped>
.test{
  max-height: fit-content;
}
</style>