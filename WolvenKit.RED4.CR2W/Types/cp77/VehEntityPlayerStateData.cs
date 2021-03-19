using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehEntityPlayerStateData : CVariable
	{
		private entEntityID _entID;
		private CInt32 _state;

		[Ordinal(0)] 
		[RED("entID")] 
		public entEntityID EntID
		{
			get => GetProperty(ref _entID);
			set => SetProperty(ref _entID, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public VehEntityPlayerStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
