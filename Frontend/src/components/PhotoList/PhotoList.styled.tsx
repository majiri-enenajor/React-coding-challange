import styled from "styled-components"

export const StyledGrid = styled.div`
  display: grid;
  grid-template-columns: repeat(1, 1fr);
  gap: 1em;
  padding: 1em;

  @media (min-width: 768px) {
    grid-template-columns: repeat(2, 1fr);
  }

  @media (min-width: 1024px) {
    grid-template-columns: repeat(3, 1fr);
    padding: 3em;
  }
`