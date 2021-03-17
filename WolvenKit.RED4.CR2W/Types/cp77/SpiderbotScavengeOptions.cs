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
			get => GetProperty(ref _scavengableBySpiderbot);
			set => SetProperty(ref _scavengableBySpiderbot, value);
		}

		public SpiderbotScavengeOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
