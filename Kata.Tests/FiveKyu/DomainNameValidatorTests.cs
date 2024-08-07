using AlbinRonnkvist.Kata.Solutions.FiveKyu;

namespace AlbinRonnkvist.Kata.Tests.FiveKyu;

public class DomainNameValidatorTests
{
    [Theory]
    [InlineData("codewars", false)]
    [InlineData("g.co", true)]
    [InlineData("subdomain.codewars.com", true)]
    [InlineData("some-horribly-long-domain-name-but-still-shorter-than-63-ch.zzz", true)]
    [InlineData("some-horribly-long-domain-name-this-time-longer-than-63-charaters.zzz", false)]
    [InlineData("some.horribly.long.domain.name.which.has.a.bunch.of.subdomains.to.be.long.enough.to.exceed.128.characters.but.is.still.shorter.than.253.characters", true)]
    [InlineData("some.horribly.long.subdomain.name.which.has.incredible.amount.of.subdomains.and.is.so.long.that.not.only.it.exceeds.128.characters.like.the.test.above.but.it.actually.manages.to.exceed.also.the.maximum.limit.of.253.characters.required.by.the.instructions", false)]
    [InlineData("a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w", true)]
    [InlineData("a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z.a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x", false)]
    public void LengthTests(string domain, bool expected)
    {
        DomainNameValidator.Solution(domain).Should().Be(expected);
    }

    [Theory]
    [InlineData("xn--example-kva.meow", true)]
    [InlineData("code-wars.com", true)]
    [InlineData("sub-domain.code-wars.com", true)]
    [InlineData("example.-com", false)]
    [InlineData("example.com-", false)]
    [InlineData("-example.com", false)]
    [InlineData("example-com", false)]
    [InlineData("subdomain-.example.com", false)]
    public void DashTests(string domain, bool expected)
    {
        DomainNameValidator.Solution(domain).Should().Be(expected);
    }

    [Theory]
    [InlineData(".", false)]
    [InlineData(".com", false)]
    [InlineData(".example.com", false)]
    [InlineData("example.", false)]
    [InlineData("example.com.", false)]
    [InlineData("example..com", false)]
    public void DotTests(string domain, bool expected)
    {
        DomainNameValidator.Solution(domain).Should().Be(expected);
    }

    [Theory]
    [InlineData("EXAMPLE.COM", true)]
    [InlineData("example:com", false)]
    [InlineData("_http._sctp.example.com", false)]
    [InlineData("example@example.com", false)]
    [InlineData("1234.com", true)]
    [InlineData("1.1.168.192.in-addr.arpa", true)]
    [InlineData("127.0.0.1", false)]
    [InlineData("mňau.cz", false)]
    public void CharacterTest(string domain, bool expected)
    {
        DomainNameValidator.Solution(domain).Should().Be(expected);
    }

    [Theory]
    [InlineData("example.a", true)]
    [InlineData("example.a1b", true)]
    [InlineData("example.1ab", true)]
    [InlineData("example.ab1", true)]
    [InlineData("example.1a2", true)]
    [InlineData("example.1-2", true)]
    [InlineData("example.123", false)]
    public void TLDTest(string domain, bool expected)
    {
        DomainNameValidator.Solution(domain).Should().Be(expected);
    }
}
