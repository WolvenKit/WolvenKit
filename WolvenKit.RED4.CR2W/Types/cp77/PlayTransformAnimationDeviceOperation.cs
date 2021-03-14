using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayTransformAnimationDeviceOperation : DeviceOperationBase
	{
		private CArray<STransformAnimationData> _transformAnimations;

		[Ordinal(5)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get
			{
				if (_transformAnimations == null)
				{
					_transformAnimations = (CArray<STransformAnimationData>) CR2WTypeManager.Create("array:STransformAnimationData", "transformAnimations", cr2w, this);
				}
				return _transformAnimations;
			}
			set
			{
				if (_transformAnimations == value)
				{
					return;
				}
				_transformAnimations = value;
				PropertySet(this);
			}
		}

		public PlayTransformAnimationDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
