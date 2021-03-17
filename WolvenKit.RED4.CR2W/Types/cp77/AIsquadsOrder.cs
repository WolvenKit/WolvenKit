using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIsquadsOrder : CVariable
	{
		private CName _squadAction;
		private CUInt32 _state;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("squadAction")] 
		public CName SquadAction
		{
			get => GetProperty(ref _squadAction);
			set => SetProperty(ref _squadAction, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CUInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public AIsquadsOrder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
