// This file is part of the re-motion Core Framework (www.re-motion.org)
// Copyright (C) 2005-2009 rubicon informationstechnologie gmbh, www.rubicon.eu
// 
// The re-motion Core Framework is free software; you can redistribute it 
// and/or modify it under the terms of the GNU Lesser General Public License 
// version 3.0 as published by the Free Software Foundation.
// 
// re-motion is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with re-motion; if not, see http://www.gnu.org/licenses.
// 
using System;
using Remotion.Data.Linq.Clauses.StreamedData;
using Remotion.Utilities;

namespace Remotion.Data.Linq.Clauses.ResultOperators
{
  /// <summary>
  /// Represents a <see cref="ResultOperatorBase"/> that is executed on a sequence, returning a scalar value or single item as its result.
  /// </summary>
  public abstract class ValueFromSequenceResultOperatorBase : ResultOperatorBase
  {
    public abstract StreamedValue ExecuteInMemory<T> (StreamedSequence sequence);

    public override IStreamedData ExecuteInMemory (IStreamedData input)
    {
      ArgumentUtility.CheckNotNull ("input", input);
      return InvokeGenericExecuteMethod<StreamedSequence, StreamedValue> (input, ExecuteInMemory<object>);
    }
  }
}