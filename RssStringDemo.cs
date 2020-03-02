using System;
using System.Collections.Generic;
using System.Text;

namespace RssSubjector
{
    class RssStringDemo
    {
        public const string RssContent = @"
<rss version='2.0'>
  <channel><title> Edi Wang</title>
<description>Latest posts from Edi Wang</description>
<link>https://edi.wang/</link>
<pubDate>Sat, 29 Feb 2020 21:39:35 GMT</pubDate>
<copyright>(c) 2020 Edi.Wang</copyright>
<generator>Moonglade</generator>
<item>
  <title>How to Check Resource Existence in Azure CLI</title>
  <link>https://edi.wang/post/2020/2/23/how-to-check-resource-existence-in-azure-cli</link>
  <description>Azure CLI can help us automate the configuration and management tasks of Azure.Ideally, for repetitive tasks, using CLI scripts can help us save time.However, Azure CLI still has some features that are not convenient enough, such as checking the existence of resources.
Current Situation


For some resource types, such as Resource Group, Azure CLI provides exists directive that can return the…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 5CC9572E-6556-4C9E-B679-F545617A4F27</guid>
  <pubDate>Sun, 23 Feb 2020 08:03:29 GMT</pubDate>
</item>
<item>
  <title>How to Check If .NET Core Program is Running under Remote Desktop</title>
  <link>https://edi.wang/post/2020/2/4/how-to-check-if-net-core-program-is-running-under-remote-desktop</link>
  <description>There are a few reasons that we need to know if our program is running under the Windows Remote Desktop (RDP) session. For example, if it is running under RDP, we may disable animation and other fancy graphics effects.But how can we detect if our program is currently under RDP? Let's see.
Windows Forms


If you are developing Windows Forms Apps using .NET Core 3.x, there's a built-in API that …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Windows Development</category>
  <category>C# and .NET</category>
  <guid isPermaLink='false'>181C72C9-B99D-4AF6-94E5-8E697527542B</guid>
  <pubDate>Tue, 04 Feb 2020 13:19:14 GMT</pubDate>
</item>
<item>
  <title>Performance Optimization for My.NET Core Blog on Azure</title>
  <link>https://edi.wang/post/2020/1/17/performance-optimization-for-my-net-core-blog-on-azure</link>
  <description>I rewrote my blog system with .NET Core last year. After more than a year of optimization, the server response time is now 8ms comparing to 80ms when it first went live. This article shares what I have done to make my blog works really fast.
In fact, before.NET Core, my old blog system was written by.NET Framework, built from ASP.NET Web Form 2.0 in 2008 all the way up to ASP.NET MVC5 in 2018. …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> ASP.NET</category>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 44EFC06B-6188-4118-9E96-D59F5160CAB4</guid>
  <pubDate>Fri, 17 Jan 2020 12:37:56 GMT</pubDate>
</item>
<item>
  <title>How to Allow Only Selected Users to Access an Application in Azure AD</title>
  <link>https://edi.wang/post/2019/12/13/how-to-allow-only-selected-users-to-access-an-application-in-azure-ad</link>
  <description>My blog supports Azure AD authentication. I created the Azure AD application inside Visual Studio, by default, all users under my Azure AD will have access to my blog's admin portal. This is not ideal for an enterprise application that needs to limit access for only a few selected users or groups. Let's see how to configure an Application in Azure AD to enable access for just a few users.
Make…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 429AE135-CE87-478A-820C-B03F7A924AD9</guid>
  <pubDate>Fri, 13 Dec 2019 07:39:25 GMT</pubDate>
</item>
<item>
  <title>Upgrade WinForms Apps from .NET Core 3.0 to 3.1</title>
  <link>https://edi.wang/post/2019/12/6/upgrade-winforms-apps-from-net-core-30-to-31</link>
  <description>I upgraded a WinForms App to .NET Core 3.1 these days. It's an open-source on-screen ruler created by Jeff Key in 2004, the original code was for .NET Framework 2.0, I've already upgraded it to.NET Core 3.0 in September this year, it was very smooth without any code change. But this time, .NET Core 3.1 does require some code changes.

The project is on my GitHub: https://github.com/EdiWang/ …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Windows Development</category>
  <category>C# and .NET</category>
  <guid isPermaLink='false'>8FFF396D-307D-4946-A0F5-C4C885E37979</guid>
  <pubDate>Fri, 06 Dec 2019 05:37:51 GMT</pubDate>
</item>
<item>
  <title>Try the New Azure .NET SDK</title>
  <link>https://edi.wang/post/2019/12/5/try-the-new-azure-net-sdk</link>
  <description>Recently, Microsoft unveiled a new Azure.NET SDK, it's not a simple version upgrade, but a major change in the programming experience. While it may take a while to adapt to the new SDK, it is worth learning. The new SDK is more powerful, more flexible and easier to use.
Current Status of Azure.NET SDKs

Currently, the official packages for .NET SDKs for Azure are confusing and unfriendly to …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> Microsot Azure</category>
  <guid isPermaLink = 'false' > 739BB31E-E88D-4087-89FA-4228C6890C05</guid>
  <pubDate>Thu, 05 Dec 2019 13:07:41 GMT</pubDate>
</item>
<item>
  <title>A Brief Introduction for Azure Front Door</title>
  <link>https://edi.wang/post/2019/11/22/a-brief-introduction-for-azure-front-door</link>
  <description>Microsoft Azure had an incident on 11/20, which it's Front Door service got a bad deployment and blown up Office 365, Bing, Azure DevOps, etc. The issue was fixed very quickly by Microsoft engineers. But Azure Front Door caught my eyes, it is new to me. So I took a look.
Azure Front Door

Typically, when we deploy our web applications to Azure App Service or other clouds, the network flow of a…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > AF7AEA2D - 0EE9-49FF-BAE6-90BD0E2968BB</guid>
  <pubDate>Fri, 22 Nov 2019 08:30:37 GMT</pubDate>
</item>
<item>
  <title>Generate a True ICO Format Image in .NET Core</title>
  <link>https://edi.wang/post/2019/11/12/generate-a-true-ico-format-image-in-net-core</link>
  <description>A while ago I finally completed the dynamic generation of favicons for my blog system.As we all know, favicon must have an icon in .ico format, and the rest can be output as png files and a manifest.json.However, this ICO format let me struggled for a while. I'd like to share my solution.
The Problem with Built-in API

As many of you may know, System.Drawing.Image has a Save method that …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <guid isPermaLink='false'> F1C8AC3E-4983-4CDB-95A8-411DD9865AA8</guid>
  <pubDate>Tue, 12 Nov 2019 13:04:14 GMT</pubDate>
</item>
<item>
  <title>.NET成人礼 | 还记得20年前一起拖过的控件吗？</title>
  <link>https://edi.wang/post/2019/10/18/dotnet-drag-control-20-years</link>
  <description>每一代人都有记忆里的味道。煤球炉、黑白电视机是属于父母的记忆。而“拖控件”式编程，启蒙了无数像我这样的80后（嗯，89也算80后）。
经典旧世

2000 年那个时候，上海这样的城市里也不是每家每户都有电脑，我家也没有电脑。我在学校经常听几位家里条件不错的同学说他们玩电脑的事情。CIH、千年虫等名词让我对电脑有着非常强烈的好奇心。而我第一次体验到计算机，是在我母亲单位的机房里。它是一台卧式机箱、15寸 CRT 凸面屏显示器的 Windows 95 电脑。
当时的微软对我来说就是神的存在。因为我认识电脑到使用电脑的一切几乎都离不开这家伟大的公司，它就像上帝一样开天辟地，创造了PC上的万物。Windows、Office、IE 这些当年几乎是唯一的主流产品。而微软的创始人之一比尔·盖茨也成了我的偶像。还记得当年，上海有个PC专题的电视频道，有一天该频…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> Events</category>
  <guid isPermaLink = 'false' > A3853E65 - 893C-4718-BEFB-77DE83572E91</guid>
  <pubDate>Fri, 18 Oct 2019 03:12:31 GMT</pubDate>
</item>
<item>
  <title>Azure Remote Controlled Light with.NET Core 3.0 on Raspberry Pi</title>
  <link>https://edi.wang/post/2019/10/6/azure-remote-controlled-light-with-net-core-30-on-raspberry-pi</link>
  <description>3 years ago, I wrote a blog post 'Azure Remote Controlled Light with Windows 10 IoT Core', which is an experiment to sending a signal from your home and it will travel around the world then come back to your home to turn on an LED light on your Raspberry Pi. 3 years later, Windows 10 IoT Core and UWP seem not living so well.Microsoft doesn't have a new build of Windows 10 to support the latest …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> Internet of Things</category>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > D313FCF1 - 1792 - 4FCB-BCDA-22F874418497</guid>
  <pubDate>Sun, 06 Oct 2019 15:59:35 GMT</pubDate>
</item>
<item>
  <title>Setup.NET Core 3.0 Runtime and SDK on Raspberry Pi 4</title>
  <link>https://edi.wang/post/2019/9/29/setup-net-core-30-runtime-and-sdk-on-raspberry-pi-4</link>
  <description>I recently bought a Raspberry Pi 4 with 4GB RAM and have official OS 'Raspbian' installed.I've managed to run an ASP.NET Core 3.0 application on this Raspberry Pi 4. (02/23/2019 Update: It's recommended to choose .NET Core 3.1 LTS now, added 3.1 content into this article)
ARM32 or ARM64?

You can't run ARM64 version of .NET Core runtime or SDK on a Raspberry Pi 4 with the official Raspbian …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> Internet of Things</category>
  <guid isPermaLink = 'false' > 088FE884-CCF9-438F-986D-401478BC862E</guid>
  <pubDate>Sun, 29 Sep 2019 09:29:07 GMT</pubDate>
</item>
<item>
  <title>This Blog Now Runs on.NET Core 3.0 and Azure</title>
  <link>https://edi.wang/post/2019/9/25/this-blog-now-runs-on-net-core-30-and-azure</link>
  <description>Microsoft shipped .NET Core 3.0 GA on Sep 23rd with tons of new features and improvements.This blog has been updated to.NET Core 3.0 and still runs on Microsoft Azure with SCD deployment type on App Service.This blog post summarizes all key points for my blog migration.
Starting with .NET Core 3.0 preview 8, I've been investigating migration for this blog, from .NET Core 2.2 to .NET Core 3.0. …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> Microsot Azure</category>
  <guid isPermaLink = 'false' > 539E989F - C25C - 4A37-BD0B-C3A4172294E6</guid>
  <pubDate>Wed, 25 Sep 2019 05:57:22 GMT</pubDate>
</item>
<item>
  <title>Migrate Azure Application Insights to ASP.NET Core 3.0</title>
  <link>https://edi.wang/post/2019/9/2/migrate-azure-application-insights-to-aspnet-core-30</link>
  <description>.NET Core 3.0 will be released at this month's .NET Conf conference, many of my friends, including me, couldn't wait to use the preview version to migrate our apps.Fortunately, starting with Preview 7, the API surface is final and can be treated as an RC version.There should be no API difference between preview 7, 8, 9 and RTM. Today I will talk about migration tips for Azure Application …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>C# and .NET</category>
  <category> Microsot Azure</category>
  <guid isPermaLink = 'false' > F4AB4FF3 - 39AD-4EEA-9E1C-950820D74AA3</guid>
  <pubDate>Mon, 02 Sep 2019 13:18:28 GMT</pubDate>
</item>
<item>
  <title>Setup Experimental Machines with Azure DevTest Lab</title>
  <link>https://edi.wang/post/2019/8/22/setup-experimental-machines-with-azure-devtest-lab</link>
  <description>Programmers and test engineers always need to set up their own environments for development and testing purposes, and these machines may only be in use for a short period of time. Typically, we use virtual machine products such as Hyper-V and VMWare on the local machine, or we use virtual machines assigned by enterprise IT administrators to do the work.
However, installing and managing these VMs…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 256AFBA5-8207-43FA-9F9E-D6AF2F82EB6D</guid>
  <pubDate>Thu, 22 Aug 2019 08:32:26 GMT</pubDate>
</item>
<item>
  <title>Deploy Ontology Blockchain DevTest Machine on Microsoft Azure</title>
  <link>https://edi.wang/post/2019/8/16/deploy-ontology-blockchain-devtest-machine-on-microsoft-azure</link>
  <description>Learning blockchain development requires development and test environment. However, it is way too difficult for me to manually set up a dev-test machine because I am completely new to blockchain and it's development workloads. Fortunately, Microsoft Azure offers virtual machine images that allow vendors to publish pre-configured images to the Azure marketplace and distribute them across Azure. …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 0C75715D-B5B9-4717-A1CB-09691139EFF8</guid>
  <pubDate>Fri, 16 Aug 2019 05:55:58 GMT</pubDate>
</item>
<item>
  <title>Create Azure Function App with.NET Core and CD from GitHub</title>
  <link>https://edi.wang/post/2019/8/10/create-azure-function-app-with-net-core-and-cd-from-github</link>
  <description>Azure Functions is an event-driven serverless compute platform that can also solve complex orchestration problems.Build and debug locally without additional setup, deploy and operate at scale in the cloud, and integrate services using triggers and bindings.For me, Function can help me quickly develop some simple APIs, and I just need to write business code instead of building fundamental code…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 2D8C69E3-3903-4778-B070-8A3D9E8C0A28</guid>
  <pubDate>Sat, 10 Aug 2019 08:32:43 GMT</pubDate>
</item>
<item>
  <title>Create a Private DNS Server without VM on Microsoft Azure</title>
  <link>https://edi.wang/post/2019/8/9/create-a-private-dns-server-without-vm-on-microsoft-azure</link>
  <description>In many companies and organizations, IT administrators typically configure internal private domain names that are inaccessible to the Internet for access to internal resources.For example, if my domain name is edi.wang, I want to use internal.edi.wang for access to the organization's internal resources. We have to install and configure our own DNS server on either Windows or Linux for this in …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 4D8D1284-48FC-4BFB-89AA-9C377F6D8B14</guid>
  <pubDate>Fri, 09 Aug 2019 01:52:59 GMT</pubDate>
</item>
<item>
  <title>Run ASP.NET Core Websites with Windows Server Core on Azure</title>
  <link>https://edi.wang/post/2019/8/7/run-aspnet-core-websites-with-windows-server-core-on-azure</link>
  <description>Microsoft Azure provides App Service that is fully managed to enable you to run websites. However, in some cases, you may still need an IaaS solution like a VM to host your website. This article will show you how to run an ASP.NET Core 2.2 web application on a Windows Server 2019 Datacenter Server Core virtual machine hosted in Azure.
About Windows Server Core

Windows was designed as an…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>IIS</category>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > 0A182D9A-42BC-42AB-8683-35E0884776AE</guid>
  <pubDate>Wed, 07 Aug 2019 05:24:02 GMT</pubDate>
</item>
<item>
  <title>Run Office 97 on iPad with RDS on Microsoft Azure</title>
  <link>https://edi.wang/post/2019/8/1/run-office-97-on-ipad-with-rds-on-microsoft-azure</link>
  <description>Apple has been trying to make the iPad as a computer, but it's never as good as a real PC. If you can run PC software on an iPad, such as a full version of Office, that would be an ideal way. The first software I used when I was a kid was Microsoft Word in Office 97, which was the first version to introduce an Office Assistant (Clippy). In honor of Clippy that died at the age of seven, I decided …</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Microsot Azure</category>
  <guid isPermaLink = 'false' > C452421A - 0065 - 4BB5-ABB0-712C29BD3207</guid>
  <pubDate>Thu, 01 Aug 2019 11:00:27 GMT</pubDate>
</item>
<item>
  <title>About Per Monitor-DPI aware for WinForms Applications</title>
  <link>https://edi.wang/post/2019/7/23/about-per-monitordpi-aware-for-winforms-applications</link>
  <description>WinForms is the traditional .NET desktop application workload running on Windows.For historical reasons, there are some problems with its support for high DPI and for different DPI screens, and this article explores the possible solutions.
Windows '96' PPI history

The default DPI for Windows systems (more precisely called PPI) is 96. PPI means pixel per inch, which means how many pixels are…</description>
  <author>Edi.Wang @outlook.com</author>
  <category>Windows Development</category>
  <category>C# and .NET</category>
  <guid isPermaLink='false'>1D421931-694D-42B3-9F9F-1603719CA1A2</guid>
  <pubDate>Tue, 23 Jul 2019 05:47:55 GMT</pubDate>
</item></channel>
</rss>";
    }
}
