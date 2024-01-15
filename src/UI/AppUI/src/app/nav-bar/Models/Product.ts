import { ICategory } from "./Category";

export interface IProduct{
    id:number;
    name:string;
    price:number;
    categoryId:number;
    category:ICategory;
}