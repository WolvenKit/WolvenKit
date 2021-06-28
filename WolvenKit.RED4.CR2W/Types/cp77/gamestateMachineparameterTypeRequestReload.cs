using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeRequestReload : IScriptable
	{
		private wCHandle<gameItemObject> _item;

		[Ordinal(0)] 
		[RED("item")] 
		public wCHandle<gameItemObject> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		public gamestateMachineparameterTypeRequestReload(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
