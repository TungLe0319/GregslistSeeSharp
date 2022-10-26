import { reactive } from 'vue'

// NOTE AppState is a reactive object to contain app level data
export const AppState = reactive({
  user: {},
  /** @type {import('./models/Account.js').Account} */
  account: {},


  /**@type {import('./models/Car.js').Car[]} */
  cars:[],

  activeListing: null,
  
  /**@type {import('./models/Home.js').Home[]} */
  homes:[],

  /**@type {import('./models/Job.js').Job[]} */
  jobs:[],
  
  
  /**@type {import('./models/SellerProfile.js').SellerProfile | null} */
  seller:null,
  
  /**@type {import('./models/Classified.js').Classified[]} */
  classifieds:[]
})
