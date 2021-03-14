using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAdditionalFloatTrackEntry : ISerializable
	{
		private CName _name;
		private animFloatTrackInfo _trackInfo;
		private curveData<CFloat> _values;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trackInfo")] 
		public animFloatTrackInfo TrackInfo
		{
			get
			{
				if (_trackInfo == null)
				{
					_trackInfo = (animFloatTrackInfo) CR2WTypeManager.Create("animFloatTrackInfo", "trackInfo", cr2w, this);
				}
				return _trackInfo;
			}
			set
			{
				if (_trackInfo == value)
				{
					return;
				}
				_trackInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("values")] 
		public curveData<CFloat> Values
		{
			get
			{
				if (_values == null)
				{
					_values = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "values", cr2w, this);
				}
				return _values;
			}
			set
			{
				if (_values == value)
				{
					return;
				}
				_values = value;
				PropertySet(this);
			}
		}

		public animAdditionalFloatTrackEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
