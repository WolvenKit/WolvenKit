using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphMenuUserData : IScriptable
	{
		private CBool _optionsListInitialized;

		[Ordinal(0)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get
			{
				if (_optionsListInitialized == null)
				{
					_optionsListInitialized = (CBool) CR2WTypeManager.Create("Bool", "optionsListInitialized", cr2w, this);
				}
				return _optionsListInitialized;
			}
			set
			{
				if (_optionsListInitialized == value)
				{
					return;
				}
				_optionsListInitialized = value;
				PropertySet(this);
			}
		}

		public MorphMenuUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
