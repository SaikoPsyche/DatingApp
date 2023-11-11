import { Photo } from "./photo";


export interface Member {
    id: number;
    userName: string;
    photoUrl: string;
    knownAs: string;
    age: number;
    gender: string;
    city: string;
    country: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    photos: Photo[];
    created: Date;
    lastActive: Date;
  }
  
