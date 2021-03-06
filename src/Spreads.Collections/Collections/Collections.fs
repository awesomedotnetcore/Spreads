﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.


// CollectionsUtils copied from: https://github.com/fsprojects/FSharpx.Collections/blob/master/src/FSharpx.Collections/Collections.fs
// License: https://github.com/fsprojects/FSharpx.Collections/blob/master/LICENSE.md
namespace Spreads.Collections

open System
open System.Diagnostics
open System.Collections
open System.Collections.Generic
open System.Runtime.InteropServices

open Spreads

[<AutoOpenAttribute>]
module CollectionsUtils =
  let inline id a = a
  let idFunc = Func<_,_>(id)
  let inline konst a _ = a
  let inline cons hd tl = hd::tl





