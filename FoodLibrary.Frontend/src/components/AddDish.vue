<template>
  <b-container>
    <b-row align-h="center">
      <div class="submit-form">
        <div v-if="!submitted">

          <div class="form-group">
            <label for="title">Tracker</label>
            <input
              type="text"
              class="form-control"
              id="Tracker"
              required
              v-model="trackerForStockPurchase"
              name="Tracker"
            />
          </div>

          <div class="form-group">
            <label for="title">Price per share</label>
            <input
              type="number"
              class="form-control"
              id="PricePerShare"
              required
              v-model="pricepershareForStockPurchase"
              name="PricePerShare"
            />
          </div>

          <div class="form-group">
            <label for="title">Amount</label>
            <input
              type="number"
              class="form-control"
              id="Amount"
              required
              v-model="amountForStockPurchase"
              name="Amount"
            />
          </div>

          <div class="form-group">
            <label for="title">Long or short</label>
            <input
              type="text"
              class="form-control"
              id="LongOrShort"
              required
              v-model="longorshortForStockPurchase"
              name="LongOrShort"
            />
          </div>

          <div class="form-group">
            <label for="title">Buy or sell</label>
            <input
              type="text"
              class="form-control"
              id="BuyOrSell"
              required
              v-model="buyorsellForStockPurchase"
              name="BuyOrSell"
            />
          </div>

          <div class="form-group">
            <label for="example-datepicker">Purchase date</label>
            <b-form-datepicker id="example-datepicker" v-model="purchasedateForStockPurchase" class="mb-2"></b-form-datepicker>
          </div>

          <!-- <button @click="submitNewStockPurchase" class="btn btn-success">Submit</button> -->
        </div>

        <!-- <div v-else>
          <h4>You submitted successfully!</h4>
          <button class="btn btn-success" @click="submitNewStockPurchase">Add</button>
        </div> -->
      </div>
    </b-row>
  </b-container>
</template>

<script lang="ts">
import FoodLibraryDataService from "../services/FoodLibraryDataService";
import axios from 'axios';
import { Vue, Component, Prop } from 'vue-property-decorator';

@Component
export default class AddDish extends Vue {

  public perPage: number = 3;
  public currentPage: number = 1;
  public items: Dish[] = [];

  public trackerForStockPurchase="VUSA";
  public pricepershareForStockPurchase=20;
  public amountForStockPurchase=30;
  public longorshortForStockPurchase="Long";
  public buyorsellForStockPurchase="Buy";
  public purchasedateForStockPurchase = new Date;

  //private newStockPurchase: StockPurchaseWithoutID = {Tracker:"",PricePerShare:0,Amount:0,LongOrShort:"",BuyOrSell:"",PurchaseDate:new Date()};

  private submitted: boolean = false;

/*   public submitNewStockPurchase():void{
    this.newStockPurchase.Tracker = this.trackerForStockPurchase;
    this.newStockPurchase.PricePerShare = this.pricepershareForStockPurchase;
    this.newStockPurchase.Amount = this.amountForStockPurchase;
    this.newStockPurchase.LongOrShort = this.longorshortForStockPurchase;
    this.newStockPurchase.BuyOrSell = this.buyorsellForStockPurchase;
    this.newStockPurchase.PurchaseDate = this.purchasedateForStockPurchase;
    console.log(this.newStockPurchase);
    StockPurchasesDataService.create(this.newStockPurchase);
  } */




}

export interface Dish {
  ID: number;
  Name: string;
  PreparationTimeMinutes: number;
  Meat: string;
  MealType: string;
}

</script>