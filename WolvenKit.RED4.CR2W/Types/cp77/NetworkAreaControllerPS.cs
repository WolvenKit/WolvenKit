using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkAreaControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(105)] [RED("visualizerID")] public CUInt32 VisualizerID { get; set; }
		[Ordinal(106)] [RED("hudActivated")] public CBool HudActivated { get; set; }
		[Ordinal(107)] [RED("currentlyAvailableCharges")] public CInt32 CurrentlyAvailableCharges { get; set; }
		[Ordinal(108)] [RED("maxAvailableCharges")] public CInt32 MaxAvailableCharges { get; set; }

		public NetworkAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
