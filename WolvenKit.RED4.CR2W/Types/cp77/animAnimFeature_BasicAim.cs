using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_BasicAim : animAnimFeature
	{
		private CInt32 _aimState;
		private CInt32 _zoomState;

		[Ordinal(0)] 
		[RED("aimState")] 
		public CInt32 AimState
		{
			get
			{
				if (_aimState == null)
				{
					_aimState = (CInt32) CR2WTypeManager.Create("Int32", "aimState", cr2w, this);
				}
				return _aimState;
			}
			set
			{
				if (_aimState == value)
				{
					return;
				}
				_aimState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("zoomState")] 
		public CInt32 ZoomState
		{
			get
			{
				if (_zoomState == null)
				{
					_zoomState = (CInt32) CR2WTypeManager.Create("Int32", "zoomState", cr2w, this);
				}
				return _zoomState;
			}
			set
			{
				if (_zoomState == value)
				{
					return;
				}
				_zoomState = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_BasicAim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
