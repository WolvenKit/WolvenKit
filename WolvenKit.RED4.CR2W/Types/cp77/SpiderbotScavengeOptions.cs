using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpiderbotScavengeOptions : CVariable
	{
		private CBool _scavengableBySpiderbot;

		[Ordinal(0)] 
		[RED("scavengableBySpiderbot")] 
		public CBool ScavengableBySpiderbot
		{
			get
			{
				if (_scavengableBySpiderbot == null)
				{
					_scavengableBySpiderbot = (CBool) CR2WTypeManager.Create("Bool", "scavengableBySpiderbot", cr2w, this);
				}
				return _scavengableBySpiderbot;
			}
			set
			{
				if (_scavengableBySpiderbot == value)
				{
					return;
				}
				_scavengableBySpiderbot = value;
				PropertySet(this);
			}
		}

		public SpiderbotScavengeOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
