import { useEffect, useState } from "react"

type Photo = {
  id: string
  color: string
  width: number
  height: number
  likes: number
  urls: {
    small: string
    full: string
  }
  user: {
    name: string
    profile_image: {
      small: string
    }
  }
}

const usePhoto = () => {
  const [photoList, setPhotoList]= useState<Photo[]>([])

  const fetchPhoto = async () => {
    try{
      const response = await fetch(process.env.NEXT_PUBLIC_BACKEND_API as string)
      const data = await response.json()
      setPhotoList([...data])
    }catch(e){
      console.log(e)
    }
  }

  useEffect(()=>{
    fetchPhoto()
  }, [])

  return photoList
}

export default usePhoto

