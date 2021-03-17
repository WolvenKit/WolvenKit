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
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("trackInfo")] 
		public animFloatTrackInfo TrackInfo
		{
			get => GetProperty(ref _trackInfo);
			set => SetProperty(ref _trackInfo, value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public curveData<CFloat> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}

		public animAdditionalFloatTrackEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
