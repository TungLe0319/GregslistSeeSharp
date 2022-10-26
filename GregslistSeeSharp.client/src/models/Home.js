export class Home{
  constructor(data) {
    this.bedrooms = data.bedrooms
    this.bathrooms= data.bathrooms
    this.levels = data.levels
    this.imgUrl = data.imgUrl
    this.year = data.year
    this.price = data.price
  }
}