using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_NodeType : questIInteractiveObjectManagerNodeType
	{
		private CArray<CHandle<questDeviceManager_NodeTypeParams>> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questDeviceManager_NodeTypeParams>> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questDeviceManager_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
