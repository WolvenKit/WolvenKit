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
			get
			{
				if (_connectedFragments == null)
				{
					_connectedFragments = (CArray<worldTrafficLaneCrowdFragment>) CR2WTypeManager.Create("array:worldTrafficLaneCrowdFragment", "connectedFragments", cr2w, this);
				}
				return _connectedFragments;
			}
			set
			{
				if (_connectedFragments == value)
				{
					return;
				}
				_connectedFragments = value;
				PropertySet(this);
			}
		}

		public worldTrafficLaneCrowdCreationInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
