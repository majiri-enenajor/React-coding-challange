import { StyledCard, StyledImage } from './PhotoCard.styled'

interface PhotoCardProps{
  id: string
  url: string
  likes: number
  handleClick: Function
  aspectRatio: number
}

export const PhotoCard: React.FC<PhotoCardProps> = ({id, url, likes, aspectRatio, handleClick}) => {
  return (
    <StyledCard onClick={() => handleClick(id)} isLong={aspectRatio >= 1.3}>
      <StyledImage src={url} alt="photocard" />
    </StyledCard>
  )
}