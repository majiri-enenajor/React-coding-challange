
import { LightBoxContainer, StyledImage, StyledBackdrop, StyledCloseButton, ImageContainer } from './LightBox.styled'

interface LightBoxProps {
  open: boolean
  url: string
  handleClose: () => void
}

export const LightBox: React.FC<LightBoxProps> = ({ url, open, handleClose }) => {
  if (!open) {
    return null
  }
  return (
    <>
    
    <LightBoxContainer>
      <ImageContainer>
      <StyledImage src={url} alt="" />
      <StyledCloseButton onClick={handleClose} />
      </ImageContainer>
      </LightBoxContainer>
    <StyledBackdrop onClick={handleClose} />
    </>
  )
}