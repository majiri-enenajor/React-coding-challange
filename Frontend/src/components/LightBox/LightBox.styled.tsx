import styled from "styled-components"

export const LightBoxContainer = styled.div`
  display: flex;
  justify-content: center;
  position: fixed;
  left: 10vw;
  top: 10vh;
  width: 80vw;
  height: 80vh;
  z-index: 2;
`

export const ImageContainer = styled.div`
  position: relative;
`

export const StyledImage = styled.img`
  height: 100%;
`

export const StyledBackdrop = styled.div`
  position: fixed;
  left: 0;
  top: 0;
  width: 100vw;
  height: 100vh;
  background: black;
  filter: opacity(0.8);
  z-index: 1;
`

export const StyledCloseButton = styled.button`
  position: absolute;
  right: 0;
  top: 0;
  z-index: 3;
  transform: translate(50%, -50%);
  padding: 1em;
  border-radius: 50%;
  outline: none;
  border: 0;
`
