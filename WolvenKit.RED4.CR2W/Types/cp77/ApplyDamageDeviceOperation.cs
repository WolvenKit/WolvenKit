using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDamageDeviceOperation : DeviceOperationBase
	{
		private CArray<SDamageOperationData> _damages;

		[Ordinal(5)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get
			{
				if (_damages == null)
				{
					_damages = (CArray<SDamageOperationData>) CR2WTypeManager.Create("array:SDamageOperationData", "damages", cr2w, this);
				}
				return _damages;
			}
			set
			{
				if (_damages == value)
				{
					return;
				}
				_damages = value;
				PropertySet(this);
			}
		}

		public ApplyDamageDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
