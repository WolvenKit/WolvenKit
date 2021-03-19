using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTimestampToBehaviorAgrument : AIbehaviortaskScript
	{
		private CName _timestampArgument;

		[Ordinal(0)] 
		[RED("timestampArgument")] 
		public CName TimestampArgument
		{
			get => GetProperty(ref _timestampArgument);
			set => SetProperty(ref _timestampArgument, value);
		}

		public SetTimestampToBehaviorAgrument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
