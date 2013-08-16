suffix = proc { |n| "#{n} bottle#{n == 1 ? '' : 's'}" }
(1..99).to_a.reverse.each do |numberOfBottles|
	puts "\n#{suffix[numberOfBottles]} bottles of beer on the wall, #{suffix[numberOfBottles]} of beer!"
	puts "Take one down and pass it around, #{suffix[numberOfBottles-1]} of beer on the wall!"
end
	