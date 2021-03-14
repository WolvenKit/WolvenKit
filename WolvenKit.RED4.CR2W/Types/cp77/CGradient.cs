using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CGradient : CResource
	{
		private CArray<rendGradientEntry> _gradientEntries;

		[Ordinal(1)] 
		[RED("gradientEntries")] 
		public CArray<rendGradientEntry> GradientEntries
		{
			get
			{
				if (_gradientEntries == null)
				{
					_gradientEntries = (CArray<rendGradientEntry>) CR2WTypeManager.Create("array:rendGradientEntry", "gradientEntries", cr2w, this);
				}
				return _gradientEntries;
			}
			set
			{
				if (_gradientEntries == value)
				{
					return;
				}
				_gradientEntries = value;
				PropertySet(this);
			}
		}

		public CGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
