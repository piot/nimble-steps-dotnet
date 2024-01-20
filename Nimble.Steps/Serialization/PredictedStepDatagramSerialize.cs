/*----------------------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved. https://github.com/piot/nimble-steps-dotnet
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------------------*/

using Piot.Clog;
using Piot.Flood;
using Piot.MonotonicTime;
using Piot.MonotonicTimeLowerBits;
using Piot.Tick;

namespace Piot.Nimble.Steps.Serialization
{
	public static class PredictedStepDatagramSerialize
	{
		/// <summary>
		/// </summary>
		public static void Serialize(IOctetWriter writer, TimeMs now,
			PredictedStepsForAllLocalPlayers steps, ILog log)
		{
			MonotonicTimeLowerBitsWriter.Write(
				new((ushort)(now.ms & 0xffff)), writer);
			PredictedStepsSerialize.Serialize(writer, steps, log);
		}
	}
}