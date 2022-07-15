import usePhoto from '../../hooks/usePhoto'
import { PhotoCard } from '../PhotoCard/PhotoCard'
import { StyledGrid } from './PhotoList.styled'
import { LightBox } from '../LightBox/LightBox'
import { useState } from 'react'

export const PhotoList = () => {
  const photoList  = usePhoto()
  const [selected, setSelected] = useState("") 
  const [open, setOpen] = useState(false)

  const openLightBox = (id: string) => {
    setSelected(id)
    setOpen(true)
  }

  const closeLightBox = () => {
    setSelected("")
    setOpen(false)
  }

  const lightboxUrl = photoList.find(p => p?.id === selected)?.urls?.full || ""
  return (
    <div>
      <h3>Photo List</h3>
      <StyledGrid>
        {photoList.map(photo => (
          <PhotoCard key={photo.id} id={photo.id} url={photo.urls.small} likes={photo.likes} handleClick={openLightBox} aspectRatio={photo.height/photo.width}/>
        ))}
      </StyledGrid>
      <LightBox open={open} url={lightboxUrl} handleClose={closeLightBox} />
    </div>
  )
}