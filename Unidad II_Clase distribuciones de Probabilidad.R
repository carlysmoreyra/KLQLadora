##Binomial ##
x <- seq(0,10,1)
p <- dbinom(x,10,0.40)
F <- pbinom(x,10,0.40)
data.frame(x=x,Prob=p, F=F)

data.frame(x=0:10,Prob=dbinom(x,10,0.40),F=pbinom(x,10,0.40))


plot(dbinom(0:10,10,0.4),type="h",xlab="x",ylab="P(X=x)",main="Función de Probabilidad Bi(10,0.4)")

##Normal##
dnorm(50,60,5)
pnorm(50,60,5) 
qnorm(0.95,60,5) 
rnorm(100,60,5)

#Densidad#
x=seq(40,80,by=0.5)
plot(x,dnorm(x,60,5), type = "l", col="blue",lwd=2,
     ylim=c(0,0.09),yaxs="i",
     xlab="x", ylab="f(x)",
     main = "Función de Densidad N(60,5)")

curve(dnorm(x,60,5),col="blue",lwd=2,
      ylim=c(0,0.09),yaxs="i",xlim=c(40,80),
      xlab="x", ylab="f(x)",
      main="Función de Densidad N(60,5)")

#Distribución#
plot(x,pnorm(x,60,5), type = "l", col="blue",lwd=2,
     yaxs="i",
     xlab="x",ylab="F(x)",main="Función de Distribución N(60,5)")

curve(pnorm(x,60,5),xlim=c(40,80),col="blue",lwd=2,
      yaxs="i",
      xlab="x",ylab="F(x)",main="Función de Distribución N(60,5)")

#Sombrear un intervalo#
regionX=seq(45,55,0.01)            # Intervalo a sombrear
xP <- c(45,regionX,55)             # Base de los polígonos que crean el efecto "sombra"
yP <- c(0,dnorm(regionX,60,5),0)   # Altura de los polígonos sombreados
curve(dnorm(x,60,5),xlim=c(40,80),yaxs="i",ylim=c(0,0.09),ylab="f(x)",
      main='Densidad N(60,5)') 
polygon(xP,yP,col="orange1")
box()


#Histograma#
X=rnorm(10000000, 60, 5)
mean(X)
sd(X)

hist(X,freq=FALSE,col="lightsalmon",main="Histograma",sub="Datos simulados de una N(60,5)")
curve(dnorm(x,60,5),xlim=c(40,80),col="blue",lwd=2,add=TRUE)
box()
