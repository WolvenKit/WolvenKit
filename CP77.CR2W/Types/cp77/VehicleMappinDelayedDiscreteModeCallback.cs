using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleMappinDelayedDiscreteModeCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)]  [RED("vehicleMappinComponent")] public wCHandle<VehicleMappinComponent> VehicleMappinComponent { get; set; }

		public VehicleMappinDelayedDiscreteModeCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
