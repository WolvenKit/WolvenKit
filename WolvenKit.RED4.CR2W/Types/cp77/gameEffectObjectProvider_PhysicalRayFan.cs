using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
	{
		private gameEffectInputParameter_Float _inputMinRayAngleDiff;

		[Ordinal(5)] 
		[RED("inputMinRayAngleDiff")] 
		public gameEffectInputParameter_Float InputMinRayAngleDiff
		{
			get
			{
				if (_inputMinRayAngleDiff == null)
				{
					_inputMinRayAngleDiff = (gameEffectInputParameter_Float) CR2WTypeManager.Create("gameEffectInputParameter_Float", "inputMinRayAngleDiff", cr2w, this);
				}
				return _inputMinRayAngleDiff;
			}
			set
			{
				if (_inputMinRayAngleDiff == value)
				{
					return;
				}
				_inputMinRayAngleDiff = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectProvider_PhysicalRayFan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
