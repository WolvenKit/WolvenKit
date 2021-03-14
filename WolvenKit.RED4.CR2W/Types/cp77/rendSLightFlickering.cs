using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendSLightFlickering : CVariable
	{
		private CFloat _positionOffset;
		private CFloat _flickerStrength;
		private CFloat _flickerPeriod;

		[Ordinal(0)] 
		[RED("positionOffset")] 
		public CFloat PositionOffset
		{
			get
			{
				if (_positionOffset == null)
				{
					_positionOffset = (CFloat) CR2WTypeManager.Create("Float", "positionOffset", cr2w, this);
				}
				return _positionOffset;
			}
			set
			{
				if (_positionOffset == value)
				{
					return;
				}
				_positionOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("flickerStrength")] 
		public CFloat FlickerStrength
		{
			get
			{
				if (_flickerStrength == null)
				{
					_flickerStrength = (CFloat) CR2WTypeManager.Create("Float", "flickerStrength", cr2w, this);
				}
				return _flickerStrength;
			}
			set
			{
				if (_flickerStrength == value)
				{
					return;
				}
				_flickerStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("flickerPeriod")] 
		public CFloat FlickerPeriod
		{
			get
			{
				if (_flickerPeriod == null)
				{
					_flickerPeriod = (CFloat) CR2WTypeManager.Create("Float", "flickerPeriod", cr2w, this);
				}
				return _flickerPeriod;
			}
			set
			{
				if (_flickerPeriod == value)
				{
					return;
				}
				_flickerPeriod = value;
				PropertySet(this);
			}
		}

		public rendSLightFlickering(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
