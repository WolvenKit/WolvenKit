using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeshAppearanceDeviceOperation : DeviceOperationBase
	{
		private CName _meshesAppearence;

		[Ordinal(5)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetProperty(ref _meshesAppearence);
			set => SetProperty(ref _meshesAppearence, value);
		}

		public MeshAppearanceDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
