using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneCrowdCreationInfo : CVariable
	{
		private CArray<worldTrafficLaneCrowdFragment> _connectedFragments;

		[Ordinal(0)] 
		[RED("connectedFragments")] 
		public CArray<worldTrafficLaneCrowdFragment> ConnectedFragments
		{
			get => GetProperty(ref _connectedFragments);
			set => SetProperty(ref _connectedFragments, value);
		}

		public worldTrafficLaneCrowdCreationInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
