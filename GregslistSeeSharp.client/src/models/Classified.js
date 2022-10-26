import { Car } from './Car.js';
import { House } from './Home.js';
import { Job } from './Job.js';
import { SellerProfile } from "./SellerProfile.js";

export class Classified {
  constructor(data) {
    this.id = data.id; //classified id
    this.listingType = data.listingType; //Car/house/Job
    this.sellerId = data.sellerId;
    this.listing = data.listing; //an entire Object car/house/job
    
this.seller = new SellerProfile(data.seller)


    switch (this.listingType) {
      case 'Car':
        this.listing = new Car(data.listing);
        break;
      case 'House':
        this.listing = new House(data.listing);
        break;
      case 'Job':
        this.listing = new Job(data.listing);
        break;
      default:
        this.listing = data.listing;
    }

    this.sellerName = data.seller.name;
    this.sellerPicture = data.seller.picture;
  }
}

//could also have another model called SellerProfile where all that information is there
//this.seller = new SellerProfile(data.seller)
