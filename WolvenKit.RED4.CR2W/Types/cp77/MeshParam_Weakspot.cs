using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeshParam_Weakspot : animAnimFeature
	{
		private CInt32 _hidden;

		[Ordinal(0)] 
		[RED("hidden")] 
		public CInt32 Hidden
		{
			get
			{
				if (_hidden == null)
				{
					_hidden = (CInt32) CR2WTypeManager.Create("Int32", "hidden", cr2w, this);
				}
				return _hidden;
			}
			set
			{
				if (_hidden == value)
				{
					return;
				}
				_hidden = value;
				PropertySet(this);
			}
		}

		public MeshParam_Weakspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
