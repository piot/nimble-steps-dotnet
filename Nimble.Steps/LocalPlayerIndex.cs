/*----------------------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved. https://github.com/piot/nimble-steps-dotnet
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------------------*/

namespace Piot.Nimble.Steps
{
	public struct LocalPlayerIndex
	{
		public byte Value;

		public LocalPlayerIndex(byte v)
		{
			Value = v;
		}

		public override string ToString()
		{
			return $"[LocalPlayerIndex {Value}]";
		}
	}
}