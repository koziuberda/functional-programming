module Lab1 where

import Prelude
import Data.List (List(..), (:))

singleton :: forall a. a -> List a
singleton x = Cons x Nil

null :: forall a. List a -> Boolean
null Nil = true
null _  = false

snoc :: forall a. List a -> a -> List a
snoc Nil x = Cons x Nil
snoc (Cons x _) y = x : y : Nil

length :: forall a. List a -> Int
length Nil = 0
length (Cons _ b) = 1 + length b