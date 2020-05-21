//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Swedish\Swedish-Choice.yaml
//     - Language: Swedish
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Swedish
{
    using System;
    using System.Collections.Generic;

    public static class ChoiceDefinitions
    {
      public const string LangMarker = @"Swe";
      public const string TokenizerRegex = @"[^\w\d\u00E0-\u00FC]";
      public const string TrueRegex = @"\b(sant|ja|yes|y|j|ok|japp|jupp|jepp|absolut|säkert|instämmer|javisst|kör)\b|(\uD83D\uDC4D|\uD83D\uDC4C)";
      public const string FalseRegex = @"\b(falskt|nej|näpp|nope|misstycker|aldrig|n|nä|absolut\s+inte|glöm det|instämmer\s+inte|vill\s+inte|avstår)\b|(\uD83D\uDC4E|\u270B|\uD83D\uDD90)";
    }
}