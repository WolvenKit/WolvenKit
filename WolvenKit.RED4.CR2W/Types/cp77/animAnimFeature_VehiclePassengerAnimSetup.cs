using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassengerAnimSetup : animAnimFeature
	{
		private CBool _enableAdditiveAnim;
		private CFloat _additiveScale;

		[Ordinal(0)] 
		[RED("enableAdditiveAnim")] 
		public CBool EnableAdditiveAnim
		{
			get
			{
				if (_enableAdditiveAnim == null)
				{
					_enableAdditiveAnim = (CBool) CR2WTypeManager.Create("Bool", "enableAdditiveAnim", cr2w, this);
				}
				return _enableAdditiveAnim;
			}
			set
			{
				if (_enableAdditiveAnim == value)
				{
					return;
				}
				_enableAdditiveAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("additiveScale")] 
		public CFloat AdditiveScale
		{
			get
			{
				if (_additiveScale == null)
				{
					_additiveScale = (CFloat) CR2WTypeManager.Create("Float", "additiveScale", cr2w, this);
				}
				return _additiveScale;
			}
			set
			{
				if (_additiveScale == value)
				{
					return;
				}
				_additiveScale = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_VehiclePassengerAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
