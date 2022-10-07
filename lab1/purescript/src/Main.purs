module Main where

import Lab1
import Prelude (Unit, discard, show, ($))
import Effect (Effect)
import Effect.Console (log)

main ∷ Effect Unit
main = do
  let firstList = singleton 5

  log "Is first list null: "
  log $ show $ null firstList

  let secondList = snoc firstList 6

  log "Second list length is: "
  log $ show $ length secondList
