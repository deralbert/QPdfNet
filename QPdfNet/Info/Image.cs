﻿//
// Image.cs
//
// Author: Kees van Spelde <sicos2002@hotmail.com>
//
// Copyright (c) 2021-2022 Kees van Spelde.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QPdfNet.Info;

/// <summary>
///     Returns information about an <see cref="Image"/> on a <see cref="Page"/>
/// </summary>
public class Image
{
    #region Properties
    /// <summary>
    ///     Returns the bits per component
    /// </summary>
    [JsonProperty("bitspercomponent")]
    public long Bitspercomponent { get; private set; }

    /// <summary>
    ///     Returns information about the color space
    /// </summary>
    [JsonProperty("colorspace")]
    public string? Colorspace { get; private set; }

    /// <summary>
    ///     Returns the used decode parameters
    /// </summary>
    [JsonProperty("decodeparms")]
    public List<object>? Decodeparms { get; private set; }

    /// <summary>
    ///     Returns the filters used
    /// </summary>
    [JsonProperty("filter")]
    public List<string>? Filter { get; private set; }

    [JsonProperty("filterable")]
    public bool Filterable { get; private set; }

    /// <summary>
    ///     Returns the height of the image
    /// </summary>
    [JsonProperty("height")]
    public long Height { get; private set; }

    /// <summary>
    ///     Returns the width of the image
    /// </summary>
    [JsonProperty("width")]
    public long Width { get; private set; }

    /// <summary>
    ///     Returns the name of the image
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; private set; }

    /// <summary>
    ///     Returns the object
    /// </summary>
    [JsonProperty("object")]
    public string? Object { get; private set; }
    #endregion
}