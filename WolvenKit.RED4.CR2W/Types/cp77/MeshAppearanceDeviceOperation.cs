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
			get
			{
				if (_meshesAppearence == null)
				{
					_meshesAppearence = (CName) CR2WTypeManager.Create("CName", "meshesAppearence", cr2w, this);
				}
				return _meshesAppearence;
			}
			set
			{
				if (_meshesAppearence == value)
				{
					return;
				}
				_meshesAppearence = value;
				PropertySet(this);
			}
		}

		public MeshAppearanceDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
