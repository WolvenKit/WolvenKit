using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedInputSetters : CVariable
	{
		private netTime _serverReplicatedTime;

		[Ordinal(0)] 
		[RED("serverReplicatedTime")] 
		public netTime ServerReplicatedTime
		{
			get => GetProperty(ref _serverReplicatedTime);
			set => SetProperty(ref _serverReplicatedTime, value);
		}

		public entReplicatedInputSetters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
