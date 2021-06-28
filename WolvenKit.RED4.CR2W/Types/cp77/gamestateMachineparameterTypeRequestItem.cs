using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeRequestItem : IScriptable
	{
		private CArray<gameEquipParam> _requests;

		[Ordinal(0)] 
		[RED("requests")] 
		public CArray<gameEquipParam> Requests
		{
			get => GetProperty(ref _requests);
			set => SetProperty(ref _requests, value);
		}

		public gamestateMachineparameterTypeRequestItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
