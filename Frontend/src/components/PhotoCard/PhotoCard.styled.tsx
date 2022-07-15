import styled from "styled-components"

export const StyledCard = styled.div<{ isLong: boolean }>`
  border-radius: 4px;
  box-shadow: 0.25rem 0.25rem 0rem rgb(0 0 0 / 5%);
  height: fit-content;
  grid-row: auto/span ${({ isLong }) => isLong ? 2 : 1};
`

export const StyledImage = styled.img`
  border-radius: 4px;
  width: 100%;
`