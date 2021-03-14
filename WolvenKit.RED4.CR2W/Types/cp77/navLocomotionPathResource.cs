using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathResource : CResource
	{
		private CArray<CHandle<navLocomotionPath>> _paths;

		[Ordinal(1)] 
		[RED("paths")] 
		public CArray<CHandle<navLocomotionPath>> Paths
		{
			get
			{
				if (_paths == null)
				{
					_paths = (CArray<CHandle<navLocomotionPath>>) CR2WTypeManager.Create("array:handle:navLocomotionPath", "paths", cr2w, this);
				}
				return _paths;
			}
			set
			{
				if (_paths == value)
				{
					return;
				}
				_paths = value;
				PropertySet(this);
			}
		}

		public navLocomotionPathResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
